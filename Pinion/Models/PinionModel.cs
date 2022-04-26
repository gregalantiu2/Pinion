using System;
namespace Pinion.Models
{
    public class PinionModel
    {
        public PinionModel()
        {
        }
        //Need to change this to identity
        public int UserId { get; set; }
        public string UserProfilePicUrl { get; set; }
        public string PinionText { get; set; }

    }
}
