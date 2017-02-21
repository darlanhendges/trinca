using DAB.DTO;

namespace DAB.Generic
{
    /// <summary>
    /// Classe base para a generic que implementa todos os outros recursos do EF
    /// </summary>
    public static class Base
    {
        public static Model _context = new Model();
    }
}
