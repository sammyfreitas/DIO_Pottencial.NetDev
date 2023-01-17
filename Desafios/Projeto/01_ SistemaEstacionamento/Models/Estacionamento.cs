namespace Projeto_Dio.Models
{
    public class Estacionamento
    {
    
        private double precoInicial;
        private double preco;
        private double horas;
        private List<string> placas = new List<string>();

        public Estacionamento (double precoInicial, double preco){
            this.precoInicial = precoInicial;
            this.preco = preco;
        }
        public void cadastrarVeiculo(){
            Console.Write("Digite a placa para adicionar: ");
            string placa = Console.ReadLine();
            placas.Add(placa);
        }
       
        public void removerVeiculo(string placa){
             placas.Remove(placa); 
        }  
        public void listarPlacas(){
            if(placas.Any()){
            foreach(string valor in placas){
                Console.WriteLine(valor);
            }
        }else{
                Console.WriteLine("Nenhuma Placa Cadastrada");
            }
        }
        public void calcularPreço(double preco, double horas, double precoInicial){
            if(horas >= 2.0){
                Console.WriteLine($"Preço Final: {preco * horas}");
            }else{
                Console.WriteLine($"Preço Final: {precoInicial}");
            }
        }
    
        
    }
}