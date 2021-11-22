using System;

public class InventoryItem
{

	private int upc, sku, qty;
	private double price, cost;
	private String name;

	public InventoryItem(String name, int upc, int sku, int qty, double price, double cost)
	{
		this.name = name;
		this.upc = upc;
		this.sku = sku;
		this.qty = qty;
		this.price = price;
		this.cost = cost;
	}

	public String getName() {
		return name;
	}

	public int getUPC() {
		return upc;
	}

	public int getSKU() {
		return sku;
	}

	public int getQuantity() {
		return qty;
	}

	public double getPrice() {
		return price;
	}

	public double getCost() {
		return cost;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setUPC(int upc) {
		this.upc = upc;
	}

	public void setQuantity(int qty) {
		this.qty = qty;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public void setCost(double cost) {
		this.cost = cost;
	}

	public void editItem(String name, int upc, int qty, double price, double cost) {
		this.name = name;
		this.upc = upc;
		this.qty = qty;
		this.price = price;
		this.cost = cost;
	}

}
