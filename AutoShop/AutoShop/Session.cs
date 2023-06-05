using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    public class Session
    {
        private Session()
        {
            context = new UserRegistrationContext();
        }

        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private UserRegistrationContext context;
        public UserRegistrationContext Context => context;
    }
}
