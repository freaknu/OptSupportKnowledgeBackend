using KnowledgeBaseAPI.Models;
using optsupport.Model;

namespace KnowledgeBaseAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(KnowledgeBaseContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        Id = "202830000235799084",
                        Title = "Overview",
                        Description = "Overview",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000235799084/logo/2421101000001547033?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000237167016", Title = "Warehouse Management Overview", Url = "/portal/en/kb/articles/warehouse-management" },
                            new Article { Id = "article_202830000299512573", Title = "Sales Challan / Convert Challan Flowchart in Erp9i", Url = "/portal/en/kb/articles/sales-challan-convert-challan-flowchart-in-Erp9i" },
                            new Article { Id = "article_202830000287347001", Title = "Stock Reordering Workflow (Inventory Management)", Url = "/inventory" },
                            new Article { Id = "article_202830000287347002", Title = "Inventory Valuation Methods Explained", Url = "/portal/en/kb/articles/inventory-valuation-methods-explained" },
                            new Article { Id = "article_202830000287347003", Title = "Cycle Counting Best Practices", Url = "/portal/en/kb/articles/cycle-counting-best-practices" },
                            new Article { Id = "article_202830000287347004", Title = "Warehouse Layout Optimization", Url = "/portal/en/kb/articles/warehouse-layout-optimization" },
                            new Article { Id = "article_202830000287347005", Title = "Cross-Docking Implementation Guide", Url = "/portal/en/kb/articles/cross-docking-implementation-guide" },
                            new Article { Id = "article_202830000287347006", Title = "Safety Stock Calculation Methods", Url = "/portal/en/kb/articles/safety-stock-calculation-methods" }
                        }
                    },
                    new Category
                    {
                        Id = "202830000151137112",
                        Title = "Erp9i - Retailgraph",
                        Description = "Easy to execute each transaction in Retailgraph with informative articles. A helpful guide for Retailer & Distributor.",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000151137112/logo/2421101000001344043?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000282746021", Title = "Third Party Integration of WhatsApp with Erp9i", Url = "/portal/en/kb/articles/third-party-integration-of-whatsapp-with-Erp9i" },
                            new Article { Id = "article_202830000276834077", Title = "How to Add HFR (health facility registration) Number in Erp9i", Url = "/portal/en/kb/articles/how-to-add-hfr-health-facility-registration-number-in-Erp9i" },
                            new Article { Id = "article_202830000270270011", Title = "Boost Your Sales Using the Smart Salesman Feature", Url = "/portal/en/kb/articles/boost-your-sales-using-the-smart-salesman-feature" },
                            new Article { Id = "article_202830000270270012", Title = "Customer Loyalty Program Setup", Url = "/portal/en/kb/articles/customer-loyalty-program-setup" },
                            new Article { Id = "article_202830000270270013", Title = "Multi-Location Inventory Management", Url = "/portal/en/kb/articles/multi-location-inventory-management" },
                            new Article { Id = "article_202830000270270014", Title = "Advanced Reporting Features", Url = "/portal/en/kb/articles/advanced-reporting-features" },
                            new Article { Id = "article_202830000270270015", Title = "Bulk Data Import Techniques", Url = "/portal/en/kb/articles/bulk-data-import-techniques" },
                            new Article { Id = "article_202830000270270016", Title = "Automated Replenishment System", Url = "/portal/en/kb/articles/automated-replenishment-system" },
                            new Article { Id = "article_202830000270270017", Title = "Seasonal Promotions Management", Url = "/portal/en/kb/articles/seasonal-promotions-management" },
                            new Article { Id = "article_202830000270270018", Title = "Vendor Performance Tracking", Url = "/portal/en/kb/articles/vendor-performance-tracking" }
                        }
                    },
                    new Category
                    {
                        Id = "202830000200512440",
                        Title = "Erp9i Admin",
                        Description = "Erp9i Admin",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000200512440/logo/2421101000001282040?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000195138030", Title = "Integrate Mobile Applications with RetailGraph/Erp9i", Url = "/portal/en/kb/articles/integrate-mobile-applications-with-retailgraph-Erp9i" },
                            new Article { Id = "article_202830000275512101", Title = "How to Import Master Data in Erp9i Admin", Url = "/portal/en/kb/articles/how-to-import-master-data-in-Erp9i-admin" },
                            new Article { Id = "article_202830000200647043", Title = "Database Configuration in Erp9i Admin", Url = "/portal/en/kb/articles/database-configuration-in-Erp9i-admin" },
                            new Article { Id = "article_202830000200647044", Title = "User Permission Levels Explained", Url = "/portal/en/kb/articles/user-permission-levels-explained" },
                            new Article { Id = "article_202830000200647045", Title = "System Backup and Recovery Procedures", Url = "/portal/en/kb/articles/system-backup-and-recovery-procedures" },
                            new Article { Id = "article_202830000200647046", Title = "Performance Optimization Techniques", Url = "/portal/en/kb/articles/performance-optimization-techniques" },
                            new Article { Id = "article_202830000200647047", Title = "Security Best Practices", Url = "/portal/en/kb/articles/security-best-practices" }
                        }
                    },
                    new Category
                    {
                        Id = "202830000200512374",
                        Title = "Erp9iPOS",
                        Description = "Comprehensive POS Billing app makes your business ordering, billing & other transitions more responsive to customers and responds faster.",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000200512374/logo/2421101000001546023?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000200611849", Title = "Requirements for implement Erp9iPOS Mobile App with Erp9i", Url = "/portal/en/kb/articles/requirements-for-integrating-Erp9ipos-mobile-app-with-retailgraph-Erp9i" },
                            new Article { Id = "article_202830000202188033", Title = "Utilizing the Dashboard in Erp9iPOS", Url = "/portal/en/kb/articles/utilizing-the-dashboard-in-Erp9ipos" },
                            new Article { Id = "article_202830000203846197", Title = "Order Fulfillment Process in Erp9iPOS", Url = "/portal/en/kb/articles/order-fulfillment-process-in-Erp9ipos" },
                            new Article { Id = "article_202830000203846198", Title = "Offline Mode Operations", Url = "/portal/en/kb/articles/offline-mode-operations" },
                            new Article { Id = "article_202830000203846199", Title = "Receipt Customization Guide", Url = "/portal/en/kb/articles/receipt-customization-guide" },
                            new Article { Id = "article_202830000203846200", Title = "Discount and Promotion Applications", Url = "/portal/en/kb/articles/discount-and-promotion-applications" },
                            new Article { Id = "article_202830000203846201", Title = "Customer Management at POS", Url = "/portal/en/kb/articles/customer-management-at-pos" },
                            new Article { Id = "article_202830000203846202", Title = "End of Day Reconciliation", Url = "/portal/en/kb/articles/end-of-day-reconciliation" }
                        }
                    },
                    new Category
                    {
                        Id = "202830000204388001",
                        Title = "Erp9iSORT",
                        Description = "Complete In-store Inventory Management System to manage stock at your fingertips from anywhere.",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000204388001/logo/2421101000001238743?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000204216102", Title = "Optimized Picking Process in Erp9iSORT Mobile Application", Url = "/portal/en/kb/articles/sorting-order-in-Erp9isort-mobile-application" },
                            new Article { Id = "article_202830000204388029", Title = "Order Review Process in the Erp9iSORT Mobile Application", Url = "/portal/en/kb/articles/order-review-process-in-the-Erp9isort-mobile-application" },
                            new Article { Id = "article_202830000204728668", Title = "Effortless Order Packing Process with Erp9iSORT Mobile App", Url = "/portal/en/kb/articles/effortless-order-packing-process-with-Erp9isort-mobile-app" },
                            new Article { Id = "article_202830000204728669", Title = "Barcode Scanning Best Practices", Url = "/portal/en/kb/articles/barcode-scanning-best-practices" },
                            new Article { Id = "article_202830000204728670", Title = "Batch and Expiry Date Management", Url = "/portal/en/kb/articles/batch-and-expiry-date-management" },
                            new Article { Id = "article_202830000204728671", Title = "Multi-User Workstation Setup", Url = "/portal/en/kb/articles/multi-user-workstation-setup" },
                            new Article { Id = "article_202830000204728672", Title = "Real-time Inventory Synchronization", Url = "/portal/en/kb/articles/real-time-inventory-synchronization" },
                            new Article { Id = "article_202830000204728673", Title = "Returns Processing Workflow", Url = "/portal/en/kb/articles/returns-processing-workflow" }
                        }
                    },
                    new Category
                    {
                        Id = "202830000221301032",
                        Title = "Technical Guides",
                        Description = "Breaking down how to better manage operations like Order Fulfillment, Purchase, Accounting & More. To give a complete preview of how to manage operations in Erp9i Suite.",
                        Image = "https://desk.zoho.com/portal/api/kbCategory/202830000221301032/logo/2421101000001545035?orgId=650045113",
                        Articles = new List<Article>
                        {
                            new Article { Id = "article_202830000220962001", Title = "Comprehensive Guide to Sales Order Management in Erp9i", Url = "/portal/en/kb/articles/comprehensive-guide-to-sales-order-management-in-Erp9i" },
                            new Article { Id = "article_202830000226897277", Title = "Navigating Purchasing Processes with Erp9i", Url = "/portal/en/kb/articles/navigating-purchasing-processes-with-Erp9i" },
                            new Article { Id = "article_202830000226897278", Title = "Advanced Accounting Configuration", Url = "/portal/en/kb/articles/advanced-accounting-configuration" },
                            new Article { Id = "article_202830000226897279", Title = "Custom Report Development", Url = "/portal/en/kb/articles/custom-report-development" },
                            new Article { Id = "article_202830000226897280", Title = "API Integration Handbook", Url = "/portal/en/kb/articles/api-integration-handbook" },
                            new Article { Id = "article_202830000226897281", Title = "Data Migration Strategies", Url = "/portal/en/kb/articles/data-migration-strategies" },
                            new Article { Id = "article_202830000226897282", Title = "System Upgrade Procedures", Url = "/portal/en/kb/articles/system-upgrade-procedures" },
                            new Article { Id = "article_202830000226897283", Title = "Troubleshooting Common Issues", Url = "/portal/en/kb/articles/troubleshooting-common-issues" },
                            new Article { Id = "article_202830000226897284", Title = "Performance Benchmarking Guide", Url = "/portal/en/kb/articles/performance-benchmarking-guide" },
                            new Article { Id = "article_202830000226897285", Title = "Custom Workflow Automation", Url = "/portal/en/kb/articles/custom-workflow-automation" }
                        }
                    }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
            if (!context.InventoryData.Any())
            {
                var allArticles = context.Articles.ToList();
                foreach (var article in allArticles)
                {
                    var inventoryData = new InventoryData
                    {
                        ArticleId = article.Id,
                        Title = $"{article.Title} - Comprehensive Guide",
                        Content = $"Detailed technical documentation and best practices for {article.Title}.",
                        ArticleLink = new ArticleLink
                        {
                            Url = article.Url,
                            Text = $"Access {article.Title} Guide"
                        },
                        Images = new List<InventoryImage>
                        {
                            new InventoryImage
                            {
                                Url = "https://support.swildesk.com/galleryDocuments/placeholder-image.jpg",
                                Caption = "Process Overview"
                            },
                            new InventoryImage
                            {
                                Url = "https://support.swildesk.com/galleryDocuments/placeholder-image.jpg",
                                Caption = "Step-by-Step Guide"
                            }
                        },
                        Author = new Author
                        {
                            Name = "Kajal Tyagi",
                            Avatar = "https://support.swildesk.com/portal/api/user/avatar/12345",
                            LastUpdated = "3 months ago"
                        },
                        AppLinks = new AppLinks
                        {
                            PlayStore = new StoreLink
                            {
                                Url = "https://play.google.com/store/apps/details?id=com.swildesk",
                                Image = "https://desk.zoho.com:443/support/ImageDisplay?blobId=12345"
                            },
                            AppStore = new StoreLink
                            {
                                Url = "https://apps.apple.com/in/app/swildesk/id6444878970",
                                Image = "https://desk.zoho.com:443/support/ImageDisplay?blobId=67890"
                            }
                        }
                    };

                    context.InventoryData.Add(inventoryData);
                }
                context.SaveChanges();
            }
        }

        private static InventoryData CreateInventoryDataForArticle(Article article)
        {
            var baseData = new InventoryData
            {
                ArticleId = article.Id,
                Title = $"{article.Title} Inventory Guide",
                ArticleLink = new ArticleLink
                {
                    Url = article.Url,
                    Text = $"Access {article.Title} Guide"
                },
                Images = new List<InventoryImage>
                {
                    new InventoryImage
                    {
                        Url = "https://support.swildesk.com/galleryDocuments/dashboard.jpg",
                        Caption = "Inventory Dashboard"
                    }
                },
                Author = new Author
                {
                    Name = "Inventory Team",
                    Avatar = "https://support.swildesk.com/avatar.jpg",
                    LastUpdated = "Recently updated"
                },
                AppLinks = new AppLinks
                {
                    PlayStore = new StoreLink
                    {
                        Url = "https://play.google.com/store/apps/details?id=com.swildesk",
                        Image = "https://example.com/playstore.png"
                    },
                    AppStore = new StoreLink
                    {
                        Url = "https://apps.apple.com/app/id12345",
                        Image = "https://example.com/appstore.png"
                    }
                }
            };

            if (article.Title.Contains("POS"))
            {
            }

            if (article.Title.Contains("SORT"))
            {
                baseData.Images.Add(new InventoryImage
                {
                    Url = "https://support.swildesk.com/sort-image.jpg",
                    Caption = "Sorting Process"
                });
            }

            return baseData;
        }
    }
}