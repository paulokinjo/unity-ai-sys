using UnityEngine;

public enum EnemyState
{
    Idle = 0,
    Aggro = 1,
    ReturnToOrigin = 2
}


public class Enemy : MonoBehaviour
{
    public Transform _player;
    public float _moveSpeed = 4;
    public float _aggroRadius = 5;
    public float _returnToOriginRadius = 15;

    public Material _aggroMat;
    public Material _neutralMat;
    public Material _returningMat;

    private float _distanceToPlayer;
    private Renderer _renderer;
    private Vector3 _originPos;

    [SerializeField] private EnemyState _curState;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _originPos = transform.position;
        _curState = EnemyState.Idle;
    }

    private void Update()
    {
        _distanceToPlayer = Vector3.Distance(transform.position, _player.position);

        switch (_curState)
        {
            case EnemyState.Idle:
                _renderer.material = _neutralMat;
                if (_distanceToPlayer <= _aggroRadius)
                {
                    _curState = EnemyState.Aggro;
                }
                break;
            case EnemyState.Aggro:
                MoveToPlayer();
                _renderer.material = _aggroMat;

                if (_distanceToPlayer >= _returnToOriginRadius)
                {
                    _curState = EnemyState.ReturnToOrigin;
                }
                break;
            case EnemyState.ReturnToOrigin:
                MoveToOriginPos();
                _renderer.material = _returningMat;

                float distanceToOrigin = Vector3.Distance(_originPos, transform.position);
                if (distanceToOrigin <= 0.05f)
                {
                    _curState = EnemyState.Idle;
                }
                break;
            default:
                break;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.25f);
        Gizmos.DrawSphere(transform.position, _aggroRadius);
        Gizmos.color = new Color(0.25f, 0.25f, 0.25f, 0.1f);
        Gizmos.DrawSphere(transform.position, _returnToOriginRadius);
    }

    private void MoveToPlayer()
    {
        transform.position += (_player.position - transform.position).normalized * Time.deltaTime * _moveSpeed;
    }

    private void MoveToOriginPos()
    {
        transform.position += (_originPos - transform.position).normalized * Time.deltaTime * _moveSpeed;
    }
}
