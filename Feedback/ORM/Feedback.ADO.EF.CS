public class FeedbackADOEF {
    public void Adicionar(Feedback feedback) {
        try {
            FeedbackContext context = new FeedbackContext();
            context.Feedback.Add(feedback);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public List<Feedback> ListarTodos() {
        try {
            FeedbackContext context = new FeedbackContext();
            List<Feedback> feedbacks = context.Feedback.ToList();

            return feedbacks;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    public void Atualizar(Feedback feedback) {
        try {
            FeedbackContext context = new FeedbackContext();
            context.Feedback.Update(feedback);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public void Deletar(Feedback feedback) {
        try {
            FeedbackContext context = new FeedbackContext();
            context.Feedback.Remove(feedback);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}