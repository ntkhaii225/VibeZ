﻿using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BlockedArtistDAO : SingletonBase<BlockedArtistDAO>
    {
        public async Task<IEnumerable<BlockedArtist>> GetAllArtist()
        {
            return await _context.BlockedArtists.AsNoTrackingWithIdentityResolution().ToListAsync();
        }
        public async Task<IEnumerable<BlockedArtist>> GetAllBlockedArtistByUserId(Guid userId)
        {
            return await _context.BlockedArtists.Where(x => x.UserId == userId).AsNoTrackingWithIdentityResolution().ToListAsync();
        }
        public async Task<BlockedArtist> GetArtistById(Guid ArtistId, Guid UserId)
        {
            var ba = await _context.BlockedArtists.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(b => b.ArtistId == ArtistId && b.UserId == UserId);
            if (ba == null) return null;
            return ba;
        }
        public async Task Add(BlockedArtist blockedArtist)
        {
            await _context.BlockedArtists.AddAsync(blockedArtist);
            await _context.SaveChangesAsync();
        }
        public async Task Update(BlockedArtist blockedArtist)
        {
            _context.Attach(blockedArtist);
            _context.Entry(blockedArtist).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(BlockedArtist blockedArtist)
        {
            _context.BlockedArtists.Remove(blockedArtist);
            await _context.SaveChangesAsync();
        }
    }
}
