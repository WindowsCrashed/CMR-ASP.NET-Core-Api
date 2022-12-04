namespace CMRWebApi.Dto
{
    public class PieceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Catalog { get; set; }
        public string Tonality { get; set; }

        public Guid ComposerId { get; set; }
        public string Composer { get; set; }   
    }
}
