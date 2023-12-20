using RabbitMQ.Client;

IConnectionFactory connection=new ConnectionFactory()
{
    Uri=new Uri("cloudamqp orda veridyi url")
};

using(var conn = connection.CreateConnection())
{
    using (var channel = conn.CreateModel())
    {
        //channel.QueueDeclare(queue:"emailQueue",
        //    )
    }
}