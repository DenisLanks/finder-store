using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSEntity.Context;
namespace DAO
{
  public abstract class DAO<Entidade,ID> :IDAO<Entidade,ID>
  {
        protected FSDbContext context;

        public DAO(){
            context = new FSDbContext();
        }

        public DAO(string connection){
            context = new FSDbContext(connection);
        }

        public DAO(FSDbContext context){
            this.context = context;
        }
        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados e automaticamente salva 
        /// </summary>
        /// <param name="entity">entidade a ser persistida</param>
        public virtual void  Insert (Entidade entity){
            Save();
        }

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public virtual void  Insert (Entidade entity,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
       public virtual void Insert (Entidade[] entities){
           Save();
       }
        
         /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem persistidas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public virtual void Insert (Entidade[] entities,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este método atualiza a entidade e salva imediatamente na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza</param>
        public virtual void Update (Entidade entity){
          Save();
        }

        /// <summary>
        /// Este método atualiza várias entidades na base de dados e atualiza imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas</param>
        public virtual void Update (Entidade[] entities){
             Save();
        }

        /// <summary>
        /// Este método atualiza uma entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza<</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public virtual void Update (Entidade entity,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este método atualiza várias entidades na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas.</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public virtual void Update (Entidade[] entities,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este método apaga a entidade da base de dados e salva  alterção imediatamente
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        public virtual void Delete (Entidade entity){

        }

        /// <summary>
        /// Este método apaga várias entidades da base de dados e salva  alterções imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        public virtual void Delete (Entidade[] entities){
            Save();        
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public virtual void Delete (Entidade entity,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public virtual void Delete (Entidade[] entities,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        public virtual void Delete (ID id){
            Save();
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public virtual void Delete (ID id,bool save){
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este método retorna todos os registros da base de dados
        /// </summary>
        /// <returns> todas as entidades da base de dados</returns>
        public abstract Entidade[] All();

        /// <summary>
        /// Este método salva as alterações na base de dados
        /// </summary>
        public void Save(){
            context.SaveChanges();
        }
  }  
}