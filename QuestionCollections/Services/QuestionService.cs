using Microsoft.EntityFrameworkCore;
using QuestionCollections.Data;
using QuestionCollections.Models;

public class QuestionService
{
    private readonly ApplicationDbContext _context;

    public QuestionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Question>> GetQuestionsAsync()
    {
        return await _context.Questions.Include(q => q.Choices).ToListAsync();
    }

    public async Task<Question> GetQuestionByIdAsync(int id)
    {
        return await _context.Questions.Include(q => q.Choices).FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task AddQuestionAsync(Question question)
    {
        _context.Questions.Add(question);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateQuestionAsync(Question question)
    {
        _context.Questions.Update(question);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteQuestionAsync(int id)
    {
        var question = await _context.Questions.FindAsync(id);
        if (question != null)
        {
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
        }
    }
}
