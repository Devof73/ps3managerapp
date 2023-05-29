using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using webMAN_Manager;

namespace System
{
    internal class DebugCommandsMenu
    {
        public static string Name { get; private set; }
        static Form _target;
        protected static List<Control> _spawns = null;
        public static bool InitializedCmd = false;
        private static Dictionary<string, EventHandler<string>> Commands;
        private static readonly Color _backColor = Color.FromArgb(24, 24, 24);
        private static readonly Color _foreColor = Color.FromArgb(160, 160, 160);
        private static ToolTip _tip = null;
        private static List<string> _informationStrings = null;
        private static string[] _defaultCommands = null;
        public static bool Showing { get; private set; }
        public static string[] CommandsInfoStrings { get => _informationStrings.ToArray(); set => _informationStrings = value.ToList(); }
        internal static int GetCommandCount()
        {
            return Commands.Count;
        }
        internal static void AddNewCommand(string command, string info, EventHandler<string> onExecuted)
        {
            Commands = Commands is null ? new Dictionary<string, EventHandler<string>>() : Commands;
            Commands.Add(command, onExecuted);
            (_informationStrings = _informationStrings is null ? new List<string>() : _informationStrings).Add(info);
        }
        /// <summary>
        /// Agrega varios nuevos comandos a la lista de comandos de la aplicación.
        /// </summary>
        /// <
        /// name="commmands">Una matriz de cadenas que representa los nombres de los nuevos comandos.</param>
        /// <param name="infos">Una matriz de cadenas que representa la información sobre los nuevos comandos.</param>
        /// <param name="executedHandlers">Una matriz de delegados de eventos que representan los controladores de eventos para los nuevos comandos.</param>
        internal static void AddNewCommands(string[] commmands, string[] infos, EventHandler<string>[] executedHandlers)
        {
            // Obtiene el número total de comandos a agregar
            var total = GetCommandCount() & infos.Length & executedHandlers.Length;
            for (int i = 0; i < total; i++)
            {
                // Agrega un nuevo comando utilizando los parámetros correspondientes.
                AddNewCommand(commmands[i], infos[i], executedHandlers[i]);
            }
        }
        private DebugCommandsMenu()
        { }
        internal static void Initialize()
        {
            if (_informationStrings is null) _informationStrings = new List<string>();
            _tip = new ToolTip();
            _spawns = new List<Control>();
            string[] defCommandNames =
                   {
                    "main_rm",
                    "main_move",
                    "main_end",
                    "main_log_ctl",
                    "main_log",
                    "main_props",
                    "main_cinfo",
                    "main_logWriterClear",
                    "main_debugClose",
                    "main_location",
                    "main_sx",
                    "main_title"
                };
            string[] defTooltips =
            {
                    "main_rm <ctl.name> | Removes the specified control.",
                    "main_move <ctl.name> | Relocates the specified control",
                    "main_end | Exits the program.",
                    "main_log_ctl | Gets controls names.",
                    "main_log <string message> | => Console.WriteLine",
                    "main_props | Show props count",
                    "main_cinfo | Writes available environment info.",
                    "main_logWriterClear | Clears all log text from debug info writer.",
                    "main_debugClose | Close the debug toolbox.",
                    "main_location <int x,y> | Sets form location.",
                    "main_sx <int sx, sy> | Sets form size.",
                    "main_title <string title> | Sets title."
                };
            _informationStrings.AddRange(defTooltips);
            _defaultCommands = defCommandNames;
        }
        internal static void Show(Form target, bool methods)
        {
            if (Showing) return;
            try
            {
                Showing = true;
                _target = target;

                if (_target is null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    Initialize();

                    EventHandler<string>[] defCommandEvents =
                    {
                    (s,e) => DefaultCommandRm(e),
                    (s,e) => DefaultCommandMv(e),
                    (s,e) => Environment.Exit(0),
                    (s,e) => DefaultCommandLogCtl(),
                    (s,e ) => Console.WriteLine(e.Split(' ')[1].Replace("_", "")),
                    (s,e) => MessageBox.Show(typeof(Program).GetProperties().Length.ToString()),
                    (s,e) => DefaultCommandCwInfo(),
                    (s,e) => {try { Console.Clear(); } catch(Exception err){MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } },
                    (s,e) => Close(),
                    (s,e) => //location
                    {
                        var args = e.Split(' ');
                        var ints = args.Length > 1 ? args[1] : null;
                        if (ints != null)
                        {
                            var xy = ints.Split(new char[]{ ','}, StringSplitOptions.RemoveEmptyEntries);
                            if (xy.Length > 1)
                            {
                                var px = int.TryParse(xy[0], out int x);
                                var py = int.TryParse(xy[1], out int y);
                                if (px & py)
                                {
                                    _target.Location = new Point(x,y);
                                }
                                else Console.WriteLine("A parameter have a invalid format/value.");
                            }
                            else Console.WriteLine("A parameter is missing.");
                        }
                        else Console.WriteLine("No size specified.");
                    },
                    (s,e) => //size
                    {
                        var args = e.Split(' ');
                        var ints = args.Length > 1 ? args[1] : null;
                        if (ints != null)
                        {
                            var xy = ints.Split(new char[]{ ','}, StringSplitOptions.RemoveEmptyEntries);
                            if (xy.Length > 1)
                            {
                                var px = int.TryParse(xy[0], out int x);
                                var py = int.TryParse(xy[1], out int y);
                                if (px & py)
                                {
                                    _target.Size = new Size(x,y);
                                }
                                else Console.WriteLine("A parameter have a invalid format/value.");
                            }
                            else Console.WriteLine("A parameter is missing.");
                        }
                        else Console.WriteLine("No point specified.");
                    },
                    (s,e) => _target.Text = e.Split(' ')[1],

                };
                    Commands = Commands is null ? new Dictionary<string, EventHandler<string>>() : Commands;
                    if (methods) DrawMethods(ref _defaultCommands, _informationStrings.ToArray(), ref defCommandEvents);

                    InitCmd(_defaultCommands, defCommandEvents);
                    var inputBox = new TextBox()
                    {
                        ForeColor = _foreColor,
                        BackColor = _backColor,
                        Visible = true,
                        BorderStyle = BorderStyle.None,
                        Width = _target.Width,
                        Dock = DockStyle.Top
                    };
                    inputBox.TextChanged += (s, e) => TextChanged(ref inputBox);
                    var commandList = new ListBox()
                    {
                        ForeColor = _foreColor,
                        BackColor = _backColor,
                        Visible = true,
                        ItemHeight = 20,
                        BorderStyle = BorderStyle.None,
                        Width = _target.Width,
                        Height = _target.Height - 20,
                        Top = 20,
                        Dock = DockStyle.Fill
                    };
                    commandList.DoubleClick += (s, e) =>
                    {
                        var sel = commandList.SelectedIndex;
                        if (sel != -1)
                        {
                            var cmd = commandList.Items[sel];
                            inputBox.Text = cmd as string;
                        }
                    };

                    commandList.SelectedIndexChanged += (s, e) =>
                    {
                        if (commandList.SelectedIndex != -1)
                        {
                            ShowTypingIndexTooltip(ref inputBox, commandList, CommandsInfoStrings[commandList.SelectedIndex]);
                        }
                    };
                    inputBox.KeyPress += (s, e) =>
                    {
                        if ((Keys)e.KeyChar == Keys.Enter)
                        {
                            KeyEnterPressed();
                        }
                        else if (e.KeyChar == (char)Keys.Tab)
                        {
                            e.Handled = true;
                            var sel = commandList.SelectedIndex;
                            if (sel != -1)
                            {
                                var cmd = commandList.Items[sel];
                                inputBox.Text = cmd as string;
                            }
                        }
                    };

                    DrawControl(_target, inputBox);
                    DrawControl(_target, commandList);
                    TextChanged(ref inputBox);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                Showing = false;
            }



        }
        private static void DrawMethods(ref string[] cmds, string[] infs, ref EventHandler<string>[] hndl)
        {
            var commands = cmds.ToList();
            var infos = infs.ToList();
            var handlers = hndl.ToList();
            var mths = _target.GetType().GetMethods();
            var props = _target.GetType().GetProperties();
            foreach (var mth in mths)
            {
                if (mth.IsPublic & mth.GetParameters().Length is 0)
                {
                    commands.Add(mth.Name);
                    infos.Add(mth.ToString());
                    handlers.Add((s, e) => mth.Invoke(_target, new object[] { }));
                }
            }
            foreach (var prop in props)
            {
                if (prop.CanRead)
                {
                    commands.Add(prop.Name);
                    infos.Add(prop.ToString());
                    handlers.Add((S, E) =>
                    {
                        var subprops = prop.GetType().GetProperties();
                        foreach (var sprops in subprops)
                        {

                            Console.WriteLine(sprops.Name + " : " + sprops.GetValue(sprops));
                        }
                        Console.WriteLine("[================]");
                    });
                }
            }
            cmds = commands.ToArray();
            infs = infos.ToArray();
            hndl = handlers.ToArray();
        }
        private static void Dispose()
        {
            Commands.Clear();
            foreach (var ctl in _spawns)
            {
                ctl.Dispose();
            }
            _target = null;
            InitializedCmd = false;

            _spawns.Clear();
        }
        private static void DefaultCommandCwInfo()
        {
            var props = typeof(Environment).GetProperties();
            foreach (var prop in props)
            {
                var v = prop.GetValue(prop).ToString();

                Console.WriteLine(prop.Name + ": " + (v.Length > 60 ? v.Substring(0, 59) : v));
            }
        }
        private static void DefaultCommandLogCtl()
        {
            foreach (var ctl in _target.Controls)
            {
                Console.WriteLine((ctl as Control).Name);
            }
        }

        private static void ShowTypingIndexTooltip(ref TextBox inputTextBox, ListBox sender, string[] collection)
        {
            if (sender.Items.Count > 0)
            {
                var sel = sender.Items[0] as string;
                var cmd = Commands.Keys.ToList();
                var size = (int)((inputTextBox.Font.Size / 2.7) * 1.8) * inputTextBox.Text.Length;
                _tip.Show(collection[cmd.IndexOf(sel)], WindowFromHandle(_target.Handle), (inputTextBox.Left + size) + sender.Width / 3, inputTextBox.Location.Y + inputTextBox.Height * 4, 7000);
            }
        }
        private static void ShowTypingIndexTooltip(ref TextBox inputTextBox, ListBox sender, string tip)
        {
            if (sender.Items.Count > 0)
            {
                var size = (int)((inputTextBox.Font.Size / 2.7) * 1.8) * inputTextBox.Text.Length;
                _tip.Show(tip, WindowFromHandle(_target.Handle), (inputTextBox.Left + size) + sender.Width / 3, inputTextBox.Location.Y + inputTextBox.Height * 4, 7000);
            }
        }
        private static IWin32Window WindowFromHandle(IntPtr handle)
        {
            IntPtr myWindowHandle = handle;
            IWin32Window w = Control.FromHandle(myWindowHandle);
            return w;
        }
        private static void InitCmd(string[] names, EventHandler<string>[] commands)
        {
            var cn = names.Length & commands.Length;
            for (int i = 0; i < cn; i++)
            {
                try
                {
                    Commands.Add(names[i], commands[i]);
                }
                catch (Exception err)
                { Console.WriteLine(err.ToString()); }
            }
        }
        private static void DefaultCommandRm(string cmd)
        {
            var args = cmd.Split(' ');
            var name = args[1];
            var cons = _target.Controls.Find(name, false);
            if (cons.Length > 0)
            {
                if (MessageBox.Show(
                    $"Are you sure from deleting {name}?", "¿?",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning) is DialogResult.OK)
                {
                    cons[0].Dispose();
                }
            }
        }
        private static void DefaultCommandMv(string cmd)
        {
            var args = cmd.Split(' ');
            var name = args[1];
            var sx = args[2];
            var sy = args[3];
            var px = int.TryParse(sx, out int x);
            var py = int.TryParse(sy, out int y);
            var cons = _target.Controls.Find(name, false);
            if (cons.Length > 0)
            {
                var c = cons[0];
                c.Location = new Point(px ? x : c.Location.X, py ? y : c.Location.Y);
            }
        }
        private static void TextChanged(ref TextBox control)
        {

            if (GetCommandCount() != 0 || Debugger.IsAttached)
            {
                var cmdList = _spawns[1] as ListBox;
                var txb = _spawns[0] as TextBox;
                cmdList.Items.Clear();
                for (int i = 0; i < GetCommandCount(); i++)
                {
                    var cmd = Commands.Keys.ToArray()[i];
                    if (cmd.Contains(control.Text) & cmd.StartsWith(control.Text))
                    {
                        cmdList.Items.Add(cmd);
                    }
                }
                cmdList.SelectedIndex = cmdList.Items.Count > 0 ? 0 : -1;
                if (cmdList.Items.Count > 0)
                {
                    var ind = cmdList.SelectedIndices.Count > 0 ? cmdList.SelectedIndices[0] : -1;
                    if (ind != -1)
                    {
                        var text = cmdList.Items[ind] as string;
                        var subind = Commands.Keys.ToList().IndexOf(text);
                        if (subind != -1)
                        {
                            ShowTypingIndexTooltip(ref txb, cmdList, _informationStrings[subind]);
                        }
                        else
                        {
                            ShowTypingIndexTooltip(ref txb, cmdList, _informationStrings[cmdList.SelectedIndex]);
                        }
                    }
                    else ShowTypingIndexTooltip(ref txb, cmdList, _informationStrings[cmdList.SelectedIndex]);
                }
                // ShowTypingIndexTooltip(ref txb, cmdList, CommandsInfoStrings);
                Console.WriteLine(cmdList.Items.Count);
            }
        }
        private static void Close()
        {
            foreach (var ctl in _spawns)
            {
                ctl.Dispose();
            }
        }
        private static void KeyEnterPressed()
        {
            var txt = _spawns[0] as TextBox;
            var cmd = Commands.Values.ToArray();
            if (txt != null & Commands.Keys.ToArray().Contains(txt.Text.Split(' ')[0]))
            {
                var args = txt.Text.Split(' ');
                if (args.Length > 0)
                {
                    var ind = Commands.Keys.ToList().IndexOf(args[0]);
                    if (ind != 1)
                    {
                        if (ind < cmd.Length)
                        {
                            if (ind is -1) return;
                            cmd[ind].Invoke(null, txt.Text);
                            Console.WriteLine($"/{txt.Text}");
                        }
                    }
                }
            }
        }
        private static void DrawControl(Form target, Control control,
        int? x = null,
        int? y = null,
        int? sx = null,
        int? sy = null,
        string text = "")
        {
            if (!control.Created)
            {
                control.CreateControl();
                control.CreateGraphics();
            }

            target.Controls.Add(control);

            if (sx != null && sy != null)
            {
                control.Size = new Drawing.Size(sx ?? 0, sy ?? 0);
            }
            if (x != null && y != null)
            {
                control.Location = new Drawing.Point(x ?? 0, y ?? 0);
            }
            if (text != "") { control.Text = text; }
            _spawns.Add(control);
            control.BringToFront();
            control.Show();

        }
    }

}
