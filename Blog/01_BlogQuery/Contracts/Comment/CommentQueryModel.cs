namespace _01_BlogQuery.Contracts.Comment
{
    public class CommentQueryModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public long Id { get; set; }
        public string CreationDate { get; set; }
        public long ParentId { get; set; }
        public string ParentName { get; set; }
        public long CommentCount { get; set; }
    }
}