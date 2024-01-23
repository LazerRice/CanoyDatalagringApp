using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanoyDatalagringApp.Entities;

public class RoleEntity
{
    [Key]
    public int Id {  get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50")]
    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserEntity> Roles { get; set; } = new HashSet<UserEntity>();


}
public class UserEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(100")]

    public string Email { get; set; } = null!;

    [Required]
    [Column(TypeName = "varchar(200")]

    public string Password { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(RoleEntity))]

    public int RoleId { get; set; }

    public virtual RoleEntity Role { get; set; } = null!;

}
