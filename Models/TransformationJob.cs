﻿namespace Hast.Remote.Bridge.Models
{
    public class TransformationJob : TransformationRequest
    {
        public string Token { get; set; }
        public int UserId { get; set; }
    }
}
