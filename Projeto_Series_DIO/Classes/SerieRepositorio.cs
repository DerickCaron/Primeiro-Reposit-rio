using System;
using System.Collections.Generic;
using Projeto_Series_DIO.Interfaces;
namespace Projeto_Series_DIO.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
            try
            {
             listaSerie[id] = objeto;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao atualizar ");
                throw;
            }
		}

		public void Exclui(int id)
		{
            bool check = false;
            for(int i = 0; i < listaSerie.Count; i++){
                    if(id == i){
                        check = true;
                         try
                        {
                            listaSerie.RemoveAt(id);
                            Console.WriteLine("Excluida com Sucesso!!!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ocorreu um erro ao deletar ");
                            throw;
                        }
                        break;
                    }
            }
            if(!check){
                Console.WriteLine("Série não encontrada!!!!");
            }
		}

		public void Insere(Serie objeto)
		{
			try
            {
             listaSerie.Add(objeto);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao atualizar ");
                throw;
            }
		}

		public List<Serie> Lista()
		{
		   try
            {
             	return listaSerie;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao Listar ");
                throw;
            }
		}

		public int ProximoId()
		{
			try
            {
              return listaSerie.Count;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao buscar o proximo Id ");
                throw;
            }
		}

		public Serie RetornaPorId(int id)
		{
			 try
            {
              return listaSerie[id];
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao retornar ");
                throw;
            }
		}
    }
}