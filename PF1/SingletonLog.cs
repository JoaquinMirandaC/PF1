namespace PF1
{
    class SingletonLog
    {
        public static SingletonLog Instance = null;
        public Log log = null;

        private SingletonLog ( )
        {
            log = new Log();
        }

        public static SingletonLog GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonLog();
            }

            return Instance;
        }

        public void WriteTextBox ( string Text )
        {
            log.WriteTextBox( Text );
        }

        public void WriteDataGrid ( string Text )
        {
            log.WriteDataGrid( Text );
        }
    }
}
