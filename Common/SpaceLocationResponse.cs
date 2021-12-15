using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class SpaceLocationResponse
    {
        public string message { get; set; }
        public SpaceLocation iss_position { get; set; }
        public string timestamp { get; set; }

    }
}