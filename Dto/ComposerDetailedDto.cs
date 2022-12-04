namespace CMRWebApi.Dto
{
    public class ComposerDetailedDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Period { get; set; }
        public string Birth { get; set; }
        public string Death { get; set; }
        public string History { get; set; }
        public string ImgPath { get; set; }

        public IEnumerable<PieceShortDto> Pieces { get; set; }
    }
}
