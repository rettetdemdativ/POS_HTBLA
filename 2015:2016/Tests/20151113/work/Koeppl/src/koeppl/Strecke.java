// Michael Köppl

package koeppl;

import java.text.DecimalFormat;

public class Strecke {
	private Punkt p1, p2;
	
	Strecke(Punkt p1, Punkt p2) {
		this.p1 = p1;
		this.p2 = p2;
	}
	
	public double length() {
		return (p2.getX() - p1.getX()) + (p2.getY() - p1.getY());
	}
	
	public String toString() {
		return "Strecke [p1=" + p1.toString() + ", p2=" + p2.toString() + "], Länge: " + new DecimalFormat("#.00").format(this.length());
	}
}
