namespace FinControle.Salario {
    class Liquido {
        public static double SalarioLiquido { get; set; }
        public static double DescontoReferencia { get; set; }

        public Liquido() { }

        public static double CalculaSalarioLiquido(double salarioBruto, double planoSaude, double vt, double vr, double inss) {
            DescontoReferencia = ((vt / 100) * salarioBruto) + ((vr / 100) * salarioBruto) + planoSaude + inss;

            SalarioLiquido = salarioBruto - DescontoReferencia;

            return SalarioLiquido;
        }

    }
}
