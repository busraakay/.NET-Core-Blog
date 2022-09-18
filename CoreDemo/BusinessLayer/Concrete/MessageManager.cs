using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _messageDal.Delete(t);
        }

        public Message2 TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public void TUpdate(Message2 t)
        {
            _messageDal.Update(t);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetInBoxWithMessageByWriter(id);
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _messageDal.GetSendBoxWithMessageByWriter(id);
        }
    }
}
