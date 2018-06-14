using Flunt.Notifications;
using Flunt.Validations;

namespace api.ViewModels.LeadViewModels
{
    public class CreateLeadViewModel : Notifiable, IValidatable
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Consorcio { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .HasMaxLen(Name, 100, "Name", "O Nome deve ter até 100 caracteres.")
                    .HasMinLen(Name, 3, "Name", "O nome deve ter no m[inimo 3 caracteres.")
                    .IsEmail(Email, "Email", "E-mail inválido.")
                    .HasMaxLen(PhoneNumber, 15, "PhoneNumber", "Número de telefone deve ter no máximo 15 números.")
                    .HasMinLen(PhoneNumber, 8, "PhoneNumber", "Número de telefone deve ter no mínimo 8 caracteres.")
                );
            }
    }
}