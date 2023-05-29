using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using webMAN_Manager.Classes.PS3;

namespace System
{
    internal static class FTP
    {
        public static string[] GetContents(string path, string usn = "", string pass = "")
        {
            FtpWebRequest webRequest = (FtpWebRequest)FtpWebRequest.Create(path.Replace("http", "ftp"));
            webRequest.Credentials = new NetworkCredential(usn, pass);
            webRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            List<string> directories = new List<string>();
            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.StartsWith(".") is false)
                {
                    directories.Add(line);

                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return directories.ToArray();
        }
        public static string[] GetFiles(string path, string usn = "", string pass = "")
        {
            FtpWebRequest webRequest = (FtpWebRequest)FtpWebRequest.Create(path.Replace("http", "ftp"));
            webRequest.Credentials = new NetworkCredential(usn, pass);
            Debug.WriteLine("Request opening.", "ftp");
            webRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            List<string> files = new List<string>();
            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.StartsWith(".") is false & Path.GetExtension(line) != "")
                {
                    files.Add(line);

                }
                line = streamReader.ReadLine();
            }
            Debug.WriteLine("Response closing with data length of " + files.Count);
            streamReader.Close();
            response.Close();
            return files.ToArray();
        }
        public static string[] GetDirectories(string path, string usn = "", string pass = "")
        {
            FtpWebRequest webRequest = (FtpWebRequest)FtpWebRequest.Create(path.Replace("http", "ftp"));
            webRequest.Credentials = new NetworkCredential(usn, pass);
            webRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            List<string> dirs = new List<string>();
            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.StartsWith(".") is false & Path.GetExtension(line) == "")
                {
                    dirs.Add(line);
                }
                line = streamReader.ReadLine();
            }
            Debug.WriteLine("Response closing with data length of " + dirs.Count);

            streamReader.Close();
            response.Close();
            return dirs.ToArray();
        }
        public static long GetLength(string path, string usn = "", string pass = "")
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(path.Replace("http", "ftp"));
                request.Proxy = null;
                request.Credentials = new NetworkCredential(usn, pass);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                long size = response.ContentLength;
                response.Close();
                return size;
            }
            catch { return 0x404; }
        }
        public static void Upload(string ftpDirectory, string safefilename, Action<Pair<long>> onProgression = null, ThreadPriority priority = ThreadPriority.Normal)
        {
            Thread p = new Thread(() =>
            {
                string path = $"{ftpDirectory.TrimEnd('/')}/{safefilename.TrimStart('/')}";
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(path);
                ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
                Pair<long> outto = new Pair<long>(0, 0);
                using (FileStream inputStream = File.OpenRead(ftpDirectory + safefilename))

                using (Stream outputStream = ftpWebRequest.GetRequestStream())
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int totalReadBytesCount = 0;
                    int readBytesCount;
                    while ((readBytesCount = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputStream.Write(buffer, 0, readBytesCount);
                        totalReadBytesCount += readBytesCount;

                        double progress = totalReadBytesCount * 100.0 / inputStream.Length;
                        outto.SetX(totalReadBytesCount);
                        outto.SetY(inputStream.Length);
                        onProgression?.Invoke(outto);
                    }
                }
            })
            {
                Priority = priority,
                IsBackground = true
            };
            p.Start();

        }
        public static void Download(string downloadFileName, string ftpFileName, string usn, string pass, EventHandler<Pair<int>> OnProgression = null, ThreadPriority priority = ThreadPriority.Normal)
        {
            Thread p = new Thread(() =>
            {
                NetworkCredential credentials = new NetworkCredential(usn, pass);

                // Query size of the file to be downloaded
                WebRequest sizeRequest = WebRequest.Create(ftpFileName);
                sizeRequest.Credentials = credentials;
                sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                int size = (int)sizeRequest.GetResponse().ContentLength;

                // Download the file
                WebRequest request = WebRequest.Create(ftpFileName);
                request.Credentials = credentials;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                Pair<int> progress = new Pair<int>(0, 0);
                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(downloadFileName))
                {
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, read);
                        if (OnProgression != null)
                        {
                            int position = (int)fileStream.Position;
                            progress.SetX(position);
                            progress.SetY(size);
                            OnProgression?.Invoke(null, progress);
                        }
                    }
                }
            })
            {
                Priority = priority,
                IsBackground = true
            };
            p.Start();
        }
    }
}
