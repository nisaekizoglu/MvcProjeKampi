﻿using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
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
        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }
        public List<Message> GetListInbox(string p)
        {
            return _messageDal.List(x => x.Receiver == p);
        }
        public List<Message> GetListSendbox(string p)
        {
            return _messageDal.List(x => x.Sender == "arda@gmail.com");
        }
        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }
        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }
        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
