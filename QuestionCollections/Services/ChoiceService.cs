using Microsoft.EntityFrameworkCore;
using QuestionCollections.Data;
using QuestionCollections.Models;

public class ChoiceService
{
    private readonly ApplicationDbContext _context;

    public ChoiceService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Choice>> GetChoicesAsync(int questionId)
    {
        return await _context.Choices.Where(c => c.QuestionId == questionId).ToListAsync();
    }

    public async Task<Choice> GetChoiceByIdAsync(int id)
    {
        return await _context.Choices.FindAsync(id);
    }

    public async Task AddChoiceAsync(Choice choice)
    {
        _context.Choices.Add(choice);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateChoiceAsync(Choice choice)
    {
        _context.Choices.Update(choice);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteChoiceAsync(int id)
    {
        var choice = await _context.Choices.FindAsync(id);
        if (choice != null)
        {
            _context.Choices.Remove(choice);
            await _context.SaveChangesAsync();
        }
    }
}
