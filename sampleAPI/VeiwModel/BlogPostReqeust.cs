namespace sampleAPI.VeiwModel
{
    public class BlogPostReqeust
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<PostRequest> PostRequests { get; set; }
    }
}
