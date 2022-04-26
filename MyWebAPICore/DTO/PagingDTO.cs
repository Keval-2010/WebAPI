namespace MyWebAPICore.DTO
{
    public class PagingDTO
    {

        const int maxPageSize = 50;
        //private object source;

        // public PagingDTO(int pageNumber, int _pageSize) 
        // {
        //     this.pageNumber = pageNumber;
        //     this._pageSize = _pageSize;

        // }
        public int pageNumber { get; set; } = 1;
        private int _pageSize { get; set; } = 5;

        public int pageSize
        {
            get { return _pageSize; }
            set
            {
                
                _pageSize = (value > maxPageSize) ? maxPageSize : value;

            }

        }
    }
}