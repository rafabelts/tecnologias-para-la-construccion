package org.example.malEjemplo;

public class ExportadorCsv implements Exportador {

  @Override
  public void exportCsv(String data) {
    System.out.println("CSV -> " + data);
  }

  @Override
  public void exportPdf(String data) {
    throw new UnsupportedOperationException("No se pueden exportar pdfs");
  }

  @Override
  public void exportXlsx(String data) {
    throw new UnsupportedOperationException("No se pueden exportar xlsx");
  }
}
