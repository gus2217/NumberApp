namespace MathProject.Dtos
{
    public class NumberToDisplayDto
    {
        public int Number { get; set; }
        public bool IsPrime { get; set; }
        public bool IsPerfect { get; set; }
        public List<string> Properties { get; set; }  // e.g., ["armstrong", "odd"]
        public int DigitSum { get; set; }  // Sum of digits
        public string FunFact { get; set; }
    }
}
