﻿namespace FirstRepo.API.Models.Domain
{
    public class Region
    {
        public Guid id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        // Navigation Property 

        // One Region has Multiple Walks
        public IEnumerable<Walk> Walks { get; set; }


    }
}
