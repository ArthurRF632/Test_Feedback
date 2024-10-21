Feedback feedback;
FeedbackADOEF feedbackADOEF;

Console.WriteLine("O que você deseja fazer?");
Console.WriteLine("1. Inserir um Feedback");
Console.WriteLine("2. Listar os Feedback;");
Console.WriteLine("3. Atualizar um Feedback;");
Console.WriteLine("4. Excluir Feedback;");
int opcao = Convert.ToInt32(Console.ReadLine());

DateTime data = DateTime.Now;
string descricao = "";
string nomeUsuario = "";
int id;

switch (opcao) {
    case 1 :
        Console.WriteLine("Digite seu nome do usuario para o feedback");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine("Fale qual o feedback");
        descricao = Console.ReadLine();
        feedback = new Feedback() {
            Usuario = nomeUsuario,
            Descricao = descricao,
            DataPublicacao = data,
            Comentario = ""
        };
        feedbackADOEF = new FeedbackADOEF();
        feedbackADOEF.Adicionar(feedback);
        break;
    case 2 :
        feedbackADOEF = new FeedbackADOEF();
        List<Feedback> feedbacks = feedbackADOEF.ListarTodos();
        foreach (Feedback feed in feedbacks) {
            Console.WriteLine(feed.Descricao);
        }
        break;
    case 3 :
        Console.WriteLine("Digite seu nome do usuario para o feedback");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite o Id do Feedback:");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o novo Feedback");
        descricao = Console.ReadLine();
        feedback = new Feedback() {
            Id = id,
            Descricao = descricao,
            Usuario = nomeUsuario,
            DataPublicacao = data,
            Comentario = ""
        };
        feedbackADOEF = new FeedbackADOEF();
        feedbackADOEF.Atualizar(feedback);
        break;
    case 4 :
        Console.WriteLine("Digite o Id do Feedback para deletar:");
        id = Convert.ToInt32(Console.ReadLine());
        feedback = new Feedback() {
            Id = id
        };
        feedbackADOEF = new FeedbackADOEF();
        feedbackADOEF.Deletar(feedback);
        break;
    default:
    Console.WriteLine("Opção invalida");
        break;
}