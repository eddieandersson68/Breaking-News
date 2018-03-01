namespace Breaking_News
{
    public interface IWebCalculator
    {
        /// <summary>
        /// Calculates the number of occurences for given keyword in html code.
        /// Takes a IWebCollector as a parameter
        /// Returns -1 if param webcoll is NULL or Webcoll.Htmlcode property is
        /// NULL/empty or if the keyword is NULL/empty
        /// </summary>
        int CalculateNumberOfHits(IWebCollector webColl, string keyword);
    }
}