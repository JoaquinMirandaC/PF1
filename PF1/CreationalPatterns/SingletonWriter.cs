using System;
using System.IO;
using System.Windows.Forms;

namespace PF1
{
    class SingletonWriter
    {
        private static SingletonWriter Instance = null;


        public int Txt { get; set; }
        public int DataGrid { get; set; }
        public int RichTextBox { get; set; }

        private SingletonWriter ( ){ }

        public static SingletonWriter GetInstance ( )
        {
            if (Instance == null)
                Instance = new SingletonWriter();
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
            FileStream logStream = File.Open( Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Logs\\text.txt" ), FileMode.Append );
            StreamWriter streamWriter = new StreamWriter( logStream );

            for (int i = 0; i < Txt; i++)
                streamWriter.WriteLine( Text );
            streamWriter.Close();

            for (int i = 0; i < DataGrid; i++)
                SingletonLog.GetInstance().WriteDataGrid( Text );
            for (int i = 0; i < RichTextBox; i++)
                SingletonLog.GetInstance().WriteTextBox( Text );
        }
    }
}
