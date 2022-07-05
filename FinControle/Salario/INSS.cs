namespace FinControle.Salario {
    class INSS {
        public static double InssFinal { get; set; }
        public double Aliquota { get; set; }
        public double Salario { get; set; }
        private static double[] ValorAuxiliar { get; set; } = new double[4];
        private static double VerificaSalario { get; set; }

        public INSS() { }

        public static double CalculaInss(double salarioBruto) {
            int i = 0;
            VerificaSalario = salarioBruto;

            if (salarioBruto <= 1212.00f && salarioBruto >= 0) {
                if (VerificaSalario - 1212.00f > 0) {
                    ValorAuxiliar[i] = (salarioBruto - 1212.00f) * (7.50f / 100);
                    i++;
                }
            }
            else {
                if (VerificaSalario - 1212.00f > 0) {
                    ValorAuxiliar[i] = 1212.00f * (7.50f / 100);
                    i++;
                }
            }

            if (salarioBruto >= 1212.01f && salarioBruto <= 2427.35f) {
                if (VerificaSalario - 1212.01f > 0) {
                    ValorAuxiliar[i] = (salarioBruto - 1212.01f) * (9.00f / 100);
                    i++;
                }
            }
            else {
                if (VerificaSalario - 1212.01f > 0) {
                    ValorAuxiliar[i] = (2427.35f - 1212.01f) * (9.00f / 100);
                    i++;
                }
            }

            if (salarioBruto >= 2427.36f && salarioBruto <= 3641.03f) {
                if (VerificaSalario - 2427.36f > 0) {
                    ValorAuxiliar[i] = (salarioBruto - 2427.36f) * (12.00f / 100);
                    i++;
                }
            }
            else {
                if (VerificaSalario - 2427.36f > 0) {
                    ValorAuxiliar[i] = (3641.03f - 2427.36f) * (12.00f / 100);
                    i++;
                }
            }

            if (salarioBruto >= 3641.04f && salarioBruto <= 7087.22f) {
                if (VerificaSalario - 3641.04f > 0) {
                    ValorAuxiliar[i] = (salarioBruto - 3641.04f) * (14.00f / 100);
                    i++;
                }
            }
            else {
                if (VerificaSalario - 3641.04f > 0) {
                    ValorAuxiliar[i] = (7087.22f - 3641.03f) * (12.00f / 100);
                    i++;
                }
            }

            foreach (double valor in ValorAuxiliar) {
                InssFinal += valor;
            }
            return InssFinal;
        }
    }
}
