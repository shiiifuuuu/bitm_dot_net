using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LT2.MODEL;
using LT2.REPOSITORY;

namespace LT2.MANAGER
{
    class MobileManager
    {
        private MobileRepository _mobileRepository = new MobileRepository();

        public bool isIMEIExist(Mobile _mobile)
        {
            return _mobileRepository.isIMEIExist(_mobile);
        }

        public void CloseConnection()
        {
            _mobileRepository.CloseConnection();
        }

        public bool addMobile(Mobile _mobile)
        {
            return _mobileRepository.addMobile(_mobile);
        }

        public List<Mobile> ShowData()
        {
            return _mobileRepository.ShowData();
        }

        public Mobile SearchMobileByImei(string searchText)
        {
            return _mobileRepository.SearchMobileByImei(searchText);
        }

        public List<Mobile> SearchMobileByPrice(string price1, string price2)
        {
            return _mobileRepository.SearchMobileByPrice(price1, price2);
        }
    }
}
