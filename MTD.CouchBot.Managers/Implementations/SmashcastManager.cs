﻿using MTD.CouchBot.Dals;
using MTD.CouchBot.Dals.Implementations;
using MTD.CouchBot.Domain.Models.Smashcast;
using System.Threading.Tasks;

namespace MTD.CouchBot.Managers.Implementations
{
    public class SmashcastManager : ISmashcastManager
    {
        private readonly ISmashcastDal _smashcastDal;

        public SmashcastManager(SmashcastDal smashcastDal)
        {
            _smashcastDal = smashcastDal;
        }

        public async Task<SmashcastChannel> GetChannelByName(string name)
        {
            return await _smashcastDal.GetChannelByName(name);
        }
    }
}
