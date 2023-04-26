
using demoapi1.Model;
using demoapi1;
using Microsoft.AspNetCore.Mvc;
namespace controller{

    [ApiController]
    [Route("/apiVilla")]
    public class VillaController : ControllerBase{


List<villaDTO> LIST =new List<villaDTO>(){
    new villaDTO(){Id=1,Name="abcd",Occupancy=10,sqft=1000},
    new villaDTO(){Id=2,Name="efgh",Occupancy=20,sqft=400},
    new villaDTO(){Id=3,Name="qwer",Occupancy=10,sqft=290},
    new villaDTO(){Id=4,Name="poiu",Occupancy=30,sqft=540}
};

        
        [HttpGet]
        public ActionResult<villaDTO> GetVillas()
        {
            return Ok (LIST);
        }

         [HttpGet("{id:int}")]
       
        public ActionResult<villaDTO> Getbyid( int id )
        {
          if (id==0){
            return BadRequest();
          }

          var  villa = LIST.FirstOrDefault(x=>x.Id==id);
           if (villa == null){
            return NotFound();
           }
            return  Ok (villa);
        }
         
          [HttpPost]
             
            public ActionResult<villaDTO> CreateVilla(villaDTO vDTO)
          {
            if(vDTO==null)
            {
                return BadRequest(vDTO);
            }
    
            LIST.Add(vDTO);
            
            return Ok (LIST);

          }

           [HttpDelete]
           public ActionResult<villaDTO>  DeleteVilla(int id) {
            if (id==0){
              return BadRequest();
            }
              var  villa = LIST.FirstOrDefault(u=>u.Id==id);
           if (villa == null){
            return NotFound();
           }
            LIST.Remove(villa);
              return Ok(LIST);
           }
           [HttpPut]
           public  ActionResult<villaDTO>  UpdateVilla ( int id ,villaDTO villaDTO)
           {
            if(villaDTO==null|| id !=villaDTO.Id)
            {
                return BadRequest(villaDTO);
            }
             var  villa = LIST.FirstOrDefault(u=>u.Id==id);
            villa.Name=villaDTO.Name;
            villa.sqft=villaDTO.sqft;
            villa.Occupancy=villaDTO.Occupancy;

            return Ok(villa);

           }
             }
             }
