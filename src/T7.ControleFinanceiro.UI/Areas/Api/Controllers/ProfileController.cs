using System;
using System.Threading.Tasks;
using System.Web.Http;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Core.Web;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;

namespace T7.ControleFinanceiro.UI.Areas.Api.Controllers
{
    public class ProfileController : BaseApiController
    {
        #region Attibutes

        private IProfileService _profileService;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="profileService"></param>
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> Update([FromBody] UpdateProfileEntity value)
        {
            try
            {
                /*
                 * Validate Input Parameter
                 */
                AssertionConcern.AssertArgumentNotNull(value, "Ocorreu um erro ao atualizar seu perfil");

                /*
                 * Get Logged UserId
                 */
                value.Id = UserId;

                /*
                 * Update Profile
                 */
                _profileService.Update(value);

                return Ok();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        #endregion
    }
}