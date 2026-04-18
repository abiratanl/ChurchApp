namespace ChurchApp.Domain.Enums;

// O que o usuário PODE FAZER no sistema (Nível de acesso)
public enum UserRole
{
    Membro = 1,      // Acesso básico (ver eventos, dados próprios)
    Patrimonio = 2,
    Tesoureiro = 3,
    Secretario = 4,  // Gestão de membros
    Dirigente = 5,   // Gestão total da congregação local
    Presidente = 6,  // Gestão total da sede e sub-congregações
    Admin = 7        // Desenvolvedor / TI
}