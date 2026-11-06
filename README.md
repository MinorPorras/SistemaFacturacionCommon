# Common Billing & Inventory Management System

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/MinorPorras/SistemaFacturacionCommon)
[![Latest Release](https://img.shields.io/github/v/release/MinorPorras/SistemaFacturacionCommon?label=latest%20release&color=blue)](https://github.com/MinorPorras/SistemaFacturacionCommon/releases/latest)
[![Last Commit](https://img.shields.io/github/last-commit/MinorPorras/SistemaFacturacionCommon?label=last%20update&color=green)](https://github.com/MinorPorras/SistemaFacturacionCommon/commits/main)
[![License](https://img.shields.io/badge/license-Restricted%20Use-red)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows%2010%2B-blue)](https://github.com/MinorPorras/SistemaFacturacionCommon#system-requirements)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8+-5C2D91?logo=.net)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/language-C%23%20%26%20VB.NET-239120)](https://github.com/MinorPorras/SistemaFacturacionCommon)
[![Status](https://img.shields.io/badge/status-In%20Production-brightgreen)](https://github.com/MinorPorras/SistemaFacturacionCommon)

![SU Common Logo](docs/assets/logoCompletoSFCommonTransparent.png)

This comprehensive software solution provides robust capabilities for inventory management, billing, and sales across various business types. While specifically optimized for bakery operations, its flexible architecture makes it highly efficient and adaptable for supermarkets, restaurants, and other retail environments.

## Installation
Installation files can be downloaded directly from the latest release:
https://github.com/MinorPorras/SistemaFacturacionCommon/releases/latest

## System Requirements
- Windows 10 or higher
- .NET Framework 4.7.2 or higher
- Compatible thermal printer (optional, for receipts and price tags)
- Internet connection required *only* for updates (updates can also be downloaded manually from the releases page for offline installation).

## Want to Contribute?
Contributions are welcome! Please open an *issue* before submitting a *pull request* to discuss the proposed changes.

---

## Core Functionalities
The application is structured around 4 main modules that handle the complete workflow of inventory and sales management:

![Calendario pedidos proveedores](docs/assets/image-1.png)

### 1. Maintenance & Inventory Management
This module manages all foundational elements used throughout the application. Key features include:
![Menu mantenimiento](docs/assets/image.png)
- **Branch Info:** Configure store details (logo, name, address, phone, email) reflected globally in the app and on printed receipts.
- **User Management:** Manage user accounts with color-coded identification for quick recognition. The system enforces Role-Based Access Control (RBAC) with two distinct roles: "Administrator" (full access) and "Cashier" (restricted to POS operations only). *(Note: The system includes a default admin account (user: `Admin`, password: `2004030`). It is highly recommended to change this password immediately after the first installation.)*
- **Clients:** Manage frequent customer profiles. *(Includes a default 'Generic' client out of the box).*
- **Suppliers:** Track supplier contact info and delivery schedules, visualized via a weekly supplier delivery calendar on the main dashboard.
- **Cash Movement Concepts:** Define custom reasons for cash entering or leaving the register, essential for accurate cash drawer reconciliations.
- **Categories & Brands:** Organize and filter products efficiently using custom taxonomies.

#### Product Maintenance
The core of the inventory module. Search, modify, delete, and add products with comprehensive details (code, name, description, brand, supplier, category, stock, base price, tax, profit margin, and selling price).
![Agregar o modificar producto](docs/assets/image-3.png)
- **Advanced Filtering:** Filter by name, code, brand, category, supplier, or view recently added items.
![Busqueda de productos](docs/assets/image-2.png)
- **Dynamic Pricing Logic:** For standard products, the system automatically calculates the selling price based on base price, tax, and profit margin. For variable-price products (e.g., items sold by weight), the cashier defines the final price at the point of sale.
- **Price Tag Printing:** Generate small shelf labels (product name, code, and price) using the receipt printer. Users can select multiple products and specify the number of copies for each directly from the interface.
![Impresión de habladores](docs/assets/image-4.png)

### 2. Billing & Sales (Point of Sale)
![Sistema de caja](docs/assets/image-5.png)
A highly customizable, comprehensive POS system designed to streamline and accelerate cashier workflows:
- Responsive interface adaptable to various screen sizes.
- Full compatibility with barcode scanners and readers.
- Direct, real-time product search from the POS interface.
- Interactive sales grid allowing manual quantity adjustments or easy item removal.
- Flexible payment processing: Cash, Card, Sinpe Móvil (Mobile Payment), Bank Deposits, and Mixed Payments, featuring automatic change calculation and split-payment utilities.
- Instant receipt generation upon sale completion, with a dedicated "Receipt Reprint" section for auditing past transactions.
- **Favorite Products Grid:** Unlimited customization of quick-access buttons for top-selling items, including custom reordering and individual button color-coding for rapid visual identification.
![finalización de ventas](docs/assets/image-6.png)

#### Accounts Receivable (CxC)
![vista de cxc](docs/assets/image-7.png)
A dedicated module allowing cashiers to generate and manage credit sales directly from the POS:
- Save accounts receivable with custom comments and assigned clients.
- View and filter accounts by status (Active, Inactive, or Paid), each color-coded for clarity.
- Modify accounts via a dedicated CxC POS interface (update products, quantities, comments, or client details).
- Process partial payments or installments, printing specific installment receipts that show the remaining balance. Once fully paid, the account status updates to "Paid," and a final receipt can be printed.
![cajaCxC](docs/assets/image-8.png)

#### Cash Register Audits (Reconciliation)
An essential system for assigning cash drawer responsibility to specific cashiers during their shifts:
1. The cashier logs in and clicks "Open Register" (or presses `F4`).
![apertura de caja](docs/assets/image-9.png)
3. They count the starting cash in the drawer and click "Start Shift".
4. During the shift, any manual cash added or removed must be logged via "Cash In" or "Cash Out" (shortcuts `F2`/`F5`). The user must select a predefined concept and add a comment/invoice number for traceability. *(Normal sales are handled automatically).*
![entrada de efectivo en caja](docs/assets/image-10.png)
6. At the end of the shift, the cashier clicks "Close Register" (`F6`). Under supervisor supervision, they count the final cash. The system automatically calculates the absolute difference (in colones) and the percentage variance between the expected and actual cash.
7. Clicking "End Shift" returns the screen to the "Open Register" view for the next cashier, carrying over the closing balance as the new starting balance.
![cierre de caja](docs/assets/image-11.png)

### 3. Reports
Administrators can analyze store performance in detail, generating visual reports within the app or exporting them as PDF documents:
- **General Sales Reports:** View total revenue, invoice count, payment method breakdown (Cash vs. Card/Mobile), and the top-performing product by sales volume within a specific date range.
![repotre de ventas](docs/assets/image-12.png)
- **Product Sales Reports:** Generate sorted lists of top-selling products based on total revenue or quantity sold, filtered by specific criteria.
![reporte de productos](docs/assets/image-13.png)
- **Cash Audit Reports:** Filter cash register reconciliations by cashier and date to analyze discrepancies and operational efficiency.
![filtrado de arqueos de caja](docs/assets/image-14.png)
![detalles de arqueo de caja](docs/assets/image-15.png)

### 4. Configurations
A streamlined configuration system that adapts to the current module (e.g., opening auto-code settings in Maintenance, favorite products in Sales, or database settings in Reports):
- **App Info & Auto-Updates:** View application details, access the changelog, and configure automatic update checks on startup.
![configuración de información de la aplicación y actualizaciones](docs/assets/image-16.png)
- **Database & Report Management:** Create database backups, restore from backups in case of data loss, and modify default directories for backups and PDF report downloads.
![configuracion de BD y reportes](docs/assets/image-17.png)
- **Auto-Code Generation:** Accelerate data entry by automatically generating the next available sequential code for customizable elements (e.g., if the highest 4-digit product code is `0162`, the system generates `0163`, or fills in any available gap like `0011`).
![GENERACIÓN AUTOMATICA DE CÓDIGOS](docs/assets/image-18.png)
- **Price Tag Management:** Individually adjust the font size for product names and prices on printed shelf labels to fit specific printer requirements.
![gestion de habladores](docs/assets/image-19.png)
- **Favorite Products Management:** Add, reorder, color-code, or remove products from the POS quick-access grid, featuring a built-in search bar for rapid setup.
![gestion de productos favoritos de caja](docs/assets/image-20.png)
