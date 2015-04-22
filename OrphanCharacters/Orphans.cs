using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Security.Permissions;

using Terraria;
using TShockAPI;
using Mono.Data.Sqlite;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using TerrariaApi.Server;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.IO;

namespace OrphanCharacters
{
    [ApiVersion(1, 17)]
    public class Orphans : TerrariaPlugin
    {
        Thread thread;
        OrphanGUI guiForm;

        public CommandArgs AdminConsoleArgs;

        public override string Name
        {
            get { return "OrphanCharacters"; }
        }
        public override string Author
        {
            get { return "Granpa-G"; }
        }
        public override string Description
        {
            get { return "Manages the list of orphaned tsCharacter table records."; }
        }
        public override Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
        public Orphans(Main game)
            : base(game)
        {
            Order = -1;
        }
        public override void Initialize()
        {
            //            ServerApi.Hooks.NetGetData.Register(this, GetData);
            ServerApi.Hooks.ServerLeave.Register(this, OnLeave);
            TShockAPI.Hooks.PlayerHooks.PlayerPostLogin += OnLogin;

            Commands.ChatCommands.Add(new Command("OrphanCharacters.allow", CommandGUI, "orphancharacters"));
            Commands.ChatCommands.Add(new Command("OrphanCharacters.allow", CommandGUI, "orphans"));
            CommandArgs c = new CommandArgs("main", null, null);

        }

        protected override void Dispose(bool disposing)
        {
            if (guiForm != null)
                guiForm.Close();

            if (disposing)
            {
                ServerApi.Hooks.ServerLeave.Deregister(this, OnLeave);
                TShockAPI.Hooks.PlayerHooks.PlayerPostLogin -= OnLogin;
            }
            base.Dispose(disposing);
        }
        private static void OnLeave(LeaveEventArgs args)
        {
        }

        private void OnLogin(TShockAPI.Hooks.PlayerPostLoginEventArgs args)
        {
        }
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]

        private void CommandGUI(CommandArgs args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            thread = new Thread(new ThreadStart(() =>
            {
                // this code is going to be executed in a separate thread
                guiForm = new OrphanGUI();

                Application.Run(guiForm);

            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            Console.WriteLine("MyHandler caught : " + e.Message);
            Console.WriteLine("Runtime terminating: {0}", args.IsTerminating);
        }
    }
}
