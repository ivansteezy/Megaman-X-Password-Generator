namespace MegamanXPasswordGenerator.source
{
    public class Criteria
    {
        public Pair<int, int> Position        { get; set; }
        public Pair<int, int> NCriteriaCode   { get; set; }
        public Pair<int, int> XCriteriaCode   { get; set; }
        public Pair<int, int> YCriteriaCode   { get; set; }
        public Pair<int, int> XYCriteriaCode  { get; set; }
        public Factors XFactors               { get; set; }
        public Factors YFactors               { get; set; }
        public Factors MainFactors            { get; set; }
    }
}
