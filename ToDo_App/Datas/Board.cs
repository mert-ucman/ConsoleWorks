namespace TODO.Datas
{
    public static class Board
    {
        private static List<Card> _todo;
        private static List<Card> _inProgress;
        private static List<Card> _done;

        public static List<Card>? Todo => _todo;
      
        public static List<Card>? InProgress=>_inProgress;  

        public static List<Card>? Done=>_done;
     
        static Board()
        {
            _todo=new List<Card>(){};
            _inProgress=new List<Card>(){};
            _done=new List<Card>(){};
        }
    }
}

