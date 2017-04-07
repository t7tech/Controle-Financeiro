using System;
using System.Threading.Tasks;
using System.Web.Http;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.UI.Areas.Api.Controllers
{
    public class AccountController : ApiController
    {
        #region Attributes

        private IRegisterService _service;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public AccountController(IRegisterService service)
        {
            _service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> Create([FromBody]RegisterEntity values)
        {
            try
            {
                /*
                 * Create Account
                 */
                await _service.Add(values);

                /*
                 * Return Status
                 */
                return Ok();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> Confirm([FromBody]ConfirmEmailEntity values)
        {
            try
            {
                /*
                 * Validate E-mail Register
                 */
                await _service.ConfirmEmail(values.UserId, values.Code);

                /*
                 * Return Status
                 */
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> UniqueEmail([FromBody]RegisterEntity values)
        {
            try
            {
                /*
                 * Check E-mail
                 */
                var result = await _service.CheckEmail(values.Email);

                /*
                 * Return Status
                 */
                return Ok(new
                {
                    isUnique = result
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        #endregion
    }
}