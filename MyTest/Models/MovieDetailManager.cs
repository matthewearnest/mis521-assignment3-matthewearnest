namespace MyTest.Models
{
    public class MovieDetailManager
    {
        public Movies movie { get; set; }
        public List<MovieTweets>? Tweets { get; set; }
        public double AverageTweetSentiment()
        {
            if (Tweets == null) return 0;
            int validTweets = 0;
            double totalTweetScore = 0;
            foreach (MovieTweets tweet in Tweets)
            {
                if (tweet.Sentiment != 0)
                {
                    validTweets++;
                    totalTweetScore += tweet.Sentiment;
                }
            }
            return totalTweetScore / validTweets;
        }
    }
}
