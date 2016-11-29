using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DAO
{
  public abstract class DAO<Entidade,ID> :IDAO<Entidade,ID> where Entidade: class
  {
        protected FSDbContext context;
        protected DbSet<Entidade> dbSet;

        public DAO(){
            context = new FSDbContext();
        }

        public DAO(DbContextOptions options){
            context = new FSDbContext(options);
        }

        public DAO(FSDbContext context){
            this.context = context;
        }
        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados e automaticamente salva 
        /// </summary>
        /// <param name="entity">entidade a ser persistida</param>
        public void  Insert (Entidade entity){
            Insert(entity, true);
            Save();
        }

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public void  Insert (Entidade entity,bool save){
            dbSet.Add(entity);
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
       public void Insert (Entidade[] entities){
           Insert(entities, true);
           Save();
       }
        
         /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem persistidas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public void Insert (Entidade[] entities,bool save){
            dbSet.AddRange(entities);
            if (save){
                Save();
            }
        }

        /// <summary>
        /// Este método atualiza a entidade e salva imediatamente na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza</param>
        public void Update (Entidade entity){
            Update(entity,true);
        }

        /// <summary>
        /// Este método atualiza várias entidades na base de dados e atualiza imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas</param>
        public void Update (Entidade[] entities){
            Update(entities, true);
        }

        /// <summary>
        /// Este método atualiza uma entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza<</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public void Update (Entidade entity,bool save){
            context.Entry<Entidade>(entity).State = EntityState.Modified;
            if (save){
                Save();
            }
        }

        /// <summary>
        /// Este método atualiza várias entidades na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas.</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public void Update (Entidade[] entities,bool save){
            foreach (var entity in entities)
            {
                context.Entry<Entidade>(entity).State = EntityState.Modified;
            }
            if(save){
                Save();
            }
        }

        /// <summary>
        /// Este método apaga a entidade da base de dados e salva  alterção imediatamente
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        public void Delete (Entidade entity){
            Delete(entity, true);
        }

        /// <summary>
        /// Este método apaga várias entidades da base de dados e salva  alterções imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        public void Delete (Entidade[] entities){
            Delete(entities, true);
            Save();        
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public void Delete (Entidade entity,bool save){
            dbSet.Remove(entity);
            if(save){
                Save();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        public void Delete (Entidade[] entities,bool save){
            dbSet.RemoveRange(entities);
            if(save){
                Save();
            }
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        public void Delete (ID id){
            Delete(id, true);
        }

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        public void Delete (ID id,bool save){
            Entidade entity = GetByID(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
            if (save){
                Save();
            }
        }

        /// <summary>
        /// Este método retorna todos os registros da base de dados
        /// </summary>
        /// <returns> todas as entidades da base de dados</returns>
        public Entidade[] All()
        {
            return dbSet.ToArray();
        }

        /// <summary>
        /// Este método salva as alterações na base de dados
        /// </summary>
        public void Save(){
            context.SaveChanges();
        }

        /// <summary>
        /// Este método retorn a uma entidade pela chave primária
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidade GetByID(ID id){
            return dbSet.Find(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists(ID id) {
            Entidade entity = GetByID(id);
            return entity != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Exists(Entidade entity)
        {
            if (entity == null)
            {
                return false;
            }            
            return dbSet.Contains(entity);
        }
    }  
}