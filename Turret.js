var bulletPrefab : Rigidbody;
var bulletSpeed : float = 10;
private var target : Transform;


function OnTriggerEnter(otherCollider : Collider) {
if (otherCollider.CompareTag("Player"))
{
target = otherCollider.transform;
Fire();
}
}

function OnTriggerExit(otherCollider : Collider) {
if (otherCollider.CompareTag("Player"))
{
target = null;
StopCoroutine(Fire()); // aborts the currently running Fire() coroutine
}
}

function Fire()
{
while (target != null)
{
var nextFire = Time.time + 1;
while (Time.time < nextFire)
{
transform.LookAt(target);
yield WaitForEndOfFrame();
}

// fire!
var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
bullet.velocity = transform.forward * bulletSpeed;
}
}