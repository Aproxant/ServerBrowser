using AutoMapper;
using ServerBrowser.Entities;
using ServerBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServerBrowser.Services
{
    public interface IServerBrowserService
    {
        IEnumerable<Servers> GetAll();
        int Create(CreateServersMap dataPost);
        bool Delete(int id);
        bool Update(int id,UpdateServer sDb);
    }
    public class ServerBrowserService : IServerBrowserService
    {
        private readonly ServersDBContext dBContext;
        private readonly IMapper mapper;
        public ServerBrowserService(ServersDBContext _dBContext, IMapper _mapper)
        {
            dBContext = _dBContext;
            mapper = _mapper;
        }
        public IEnumerable<Servers> GetAll()
        {
            var Servers = dBContext.ServerList.ToList();
            return Servers;
        }
        public int Create(CreateServersMap dataPost)
        {
            var data = mapper.Map<Servers>(dataPost);
            data.lastActive = DateTime.Now;
            dBContext.ServerList.Add(data);
            dBContext.SaveChanges();
            return data.Id;
        }
        public bool Delete(int id)
        {
            var server = dBContext.ServerList.FirstOrDefault(r => r.Id == id);
            if(server is null)
                return false;
            dBContext.ServerList.Remove(server);
            dBContext.SaveChanges();
            return true;
        }
        public bool Update(int id,UpdateServer sDb)
        {
            var server = dBContext.ServerList.FirstOrDefault(r => r.Id == id);
            if (server is null)
                return false;
            server.lastActive = DateTime.Now;
            server.Mode = sDb.Mode;
            server.playerNumber = sDb.PlayerNumber;
            dBContext.SaveChanges();
            return true;
        }
    }
}
