 var target : Transform; 
 var moveSpeed = 3; 
 var rotationSpeed = 3; 
 var range : float=10f;
 var range2 : float=10f;
 var stop : float=0;
 var myTransform : Transform; 
 function Awake()
 {
     myTransform = transform; 
 }
  
 function Start()
 {
      target = GameObject.FindWithTag("Player").transform; 
  
 }
  
 function Update () {
     //rotate to look at the player
     var distance = Vector3.Distance(myTransform.position, target.position);
     if (distance<=range2 &&  distance>=range){
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
  
  
     else if(distance<=range && distance>stop){
  
     //move towards the player
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     }
     else if (distance<=stop) {
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
  
  
 }