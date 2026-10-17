namespace PagingSortingFilterationEx.Models
{
    public class QueryObject
    {
        public decimal? MinimumCreditLimit { get; set; }
        public decimal? MaximumCreditLimit { get; set; }
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageSize { get; set; } = 3;
        public int PageNumber { get; set; } = 1;
    }
}
