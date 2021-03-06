namespace DAO
{
    /// <summary>
    /// Esta interface define os métodos obrigatórios para toda classe de (Data Access Object)
    /// </summary>
    public interface IDAO<Entity,ID> where Entity : class{

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados e automaticamente salva 
        /// </summary>
        /// <param name="entity">entidade a ser persistida</param>
        void Insert (Entity entity);

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        void Insert (Entity entity,bool save);

        /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser persistida</param>
        void Insert (Entity[] entities);
        
         /// <summary>
        /// Este metodo insere uma nova entidade na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem persistidas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        void Insert (Entity[] entities,bool save);

        /// <summary>
        /// Este método atualiza a entidade e salva imediatamente na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza</param>
        void Update (Entity entity);

        /// <summary>
        /// Este método atualiza várias entidades na base de dados e atualiza imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas</param>
        void Update (Entity[] entities);

        /// <summary>
        /// Este método atualiza uma entidade na base de dados
        /// </summary>
        /// <param name="entity"> entidade a ser atualiza<</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        void Update (Entity entity,bool save);

        /// <summary>
        /// Este método atualiza várias entidades na base de dados
        /// </summary>
        /// <param name="entities"> entidades a serem atualizadas.</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        void Update (Entity[] entities,bool save);

        /// <summary>
        /// Este método apaga a entidade da base de dados e salva  alterção imediatamente
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        void Delete (Entity entity);

        /// <summary>
        /// Este método apaga várias entidades da base de dados e salva  alterções imediatamente
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        void Delete (Entity[] entities);

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="entity"> entidade a ser apagada.</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        void Delete (Entity entity,bool save);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"> entidades a serem apagadas</param>
        /// <param name="save"> indica se as entiddes devem ser salvas imediatamente.</param>
        void Delete (Entity[] entities,bool save);

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        void Delete (ID id);

        /// <summary>
        ///  Este método apaga a entidade da base de dados e salva
        /// </summary>
        /// <param name="id"> chave primaria da entidade a ser removida</param>
        /// <param name="save"> indica se a entidde deve ser salva imediatamente.</param>
        void Delete (ID id,bool save);

        /// <summary>
        /// Este método retorna todos os registros da base de dados
        /// </summary>
        /// <returns> todas as entidades da base de dados</returns>
        Entity[] All();       

        /// <summary>
        /// Este método salva as alterações na base de dados
        /// </summary>
        void Save();
        /// <summary>
        /// Este método obtém uma entidade pela chave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Entity GetByID(ID id);

    }
}
