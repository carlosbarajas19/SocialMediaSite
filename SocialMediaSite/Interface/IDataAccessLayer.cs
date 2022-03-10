using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaSite.Models;

namespace SocialMediaSite.DAL
{
    public interface IDataAccessLayer
    {
        void CreatePage(string userId);

        UserPage GetPage(string userId);

        void UpdatePage(UserPage page);
    }
}
