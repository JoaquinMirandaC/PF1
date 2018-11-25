using System;
using System.IO;

namespace PF1
{
    class SingletonWriter
    {
        private static SingletonWriter Instance = null;

        FileStream logStream;
        StreamWriter streamWriter;

        public int Txt { get; set; }
        public int DataGrid { get; set; }
        public int RichTextBox { get; set; }

        private SingletonWriter ( )
        {
            logStream = File.Open( Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Logs\" ), FileMode.Create );
            streamWriter = new StreamWriter( logStream );
        }

        ~SingletonWriter ( )
        {
            try
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception) { }
        }

        public static SingletonWriter GetInstance ( )
        {
            if (Instance == null)
            {
                Instance = new SingletonWriter();
            }
            return Instance;
        }

        public void SaveLogs ( int Txt, int DataGrid, int RichTextBox )
        {
            this.Txt = Txt;
            this.DataGrid = DataGrid;
            this.RichTextBox = RichTextBox;
        }

        public void Write ( string Text )
        {
            for (int i = 0; i < Txt; i++)
                streamWriter.Write( $"{Text}\n" );
            for (int i = 0; i < DataGrid; i++)
                SingletonLog.GetInstance().WriteDataGrid( Text );
            for (int i = 0; i < RichTextBox; i++)
                SingletonLog.GetInstance().WriteTextBox( Text );
        }
    }
}
