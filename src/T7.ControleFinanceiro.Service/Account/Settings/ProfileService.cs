using System;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;

namespace T7.ControleFinanceiro.Service.Account.Settings
{
    public class ProfileService : IProfileService
    {

        #region Attributes

        private IProfileRepository _profileRepository;

        #endregion

        #region Ctor

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UpdateProfileEntity GetById(string id)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotEmpty(id, "Usuário não encontrado");

            /*
             * Find User
             */
            var result = _profileRepository.GetById(id);
            if (result == null)
                throw new Exception("Usuário não encontrado");

            return new UpdateProfileEntity
            {
                Name = result.Name,
                LastName = result.LastName,
                Email = result.EmailOptional,
                DateBirth = result.DateBirth
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(UpdateProfileEntity entity)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(entity, "As informações inseridas são inválidas");
            AssertionConcern.AssertArgumentNotEmpty(entity.Name, "Informe seu nome");
            AssertionConcern.AssertArgumentNotEmpty(entity.LastName, "Informe seu sobrenome");
            AssertionConcern.AssertArgumentNotNull(entity.DateBirth, "Informe sua data de nascimento");

            /*
             * Update Profile
             */
            _profileRepository.Update(entity);
        }

        #endregion
    }
}