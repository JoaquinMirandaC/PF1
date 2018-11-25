namespace PF1
{
    class SingletonLog
    {
        static private SingletonLog Instance = null;
        int Txt = 0;
        int DataGrid = 0;
        int RichTextBox = 0;

        private SingletonLog ( ) { }

        static public SingletonLog GetInstance()
        {
            if(Instance == null)
            {
                Instance = new SingletonLog();
            }
            return Instance;
        }

        public void SaveLogs(int Txt, int DataGrid, int RichTextBox)
        {
            this.Txt = Txt;
            this.DataGrid = DataGrid;
            this.RichTextBox = RichTextBox;
        }

        public void Write(string Text)
        {

        }
    }
}
