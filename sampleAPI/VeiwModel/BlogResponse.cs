﻿namespace sampleAPI.VeiwModel
{
    public class BlogResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<PostResponse> PostList { get; set; }
    }
}
