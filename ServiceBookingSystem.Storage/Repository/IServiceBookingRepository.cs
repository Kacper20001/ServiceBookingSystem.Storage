using ServiceBookingSystem.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Repository
{
    public interface IServiceBookingRepository
    {
        // User Management
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(string userId);
        Task AddUserAsync(User user);
        Task DeleteUserAsync(string userId);
        Task UpdateUserAsync(User user);

        // Role Management
        Task<List<Role>> GetRolesAsync();
        Task<Role> GetRoleByIdAsync(int roleId);
        Task AddRoleAsync(Role role);
        Task DeleteRoleAsync(int roleId);
        Task UpdateRoleAsync(Role role);

        // Service Management
        Task<List<Service>> GetServicesAsync();
        Task<Service> GetServiceByIdAsync(int serviceId);
        Task AddServiceAsync(Service service);
        Task DeleteServiceAsync(int serviceId);
        Task UpdateServiceAsync(Service service);

        // Service Category Management
        Task<List<ServiceCategory>> GetServiceCategoriesAsync();
        Task<ServiceCategory> GetServiceCategoryByIdAsync(int categoryId);
        Task AddServiceCategoryAsync(ServiceCategory category);
        Task DeleteServiceCategoryAsync(int categoryId);
        Task UpdateServiceCategoryAsync(ServiceCategory category);

        // Reservation Management
        Task<List<Reservation>> GetReservationsAsync();
        Task<List<Reservation>> GetReservationsByUserIdAsync(string userId);
        Task<Reservation> GetReservationByIdAsync(int reservationId);
        Task AddReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int reservationId);
        Task UpdateReservationAsync(Reservation reservation);

        // Payment Management
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> GetPaymentByIdAsync(int paymentId);
        Task AddPaymentAsync(Payment payment);
        Task DeletePaymentAsync(int paymentId);
        Task UpdatePaymentAsync(Payment payment);

        // Review Management
        Task<List<Review>> GetReviewsAsync();
        Task<List<Review>> GetReviewsByServiceIdAsync(int serviceId);
        Task<Review> GetReviewByIdAsync(int reviewId);
        Task AddReviewAsync(Review review);
        Task DeleteReviewAsync(int reviewId);
        Task UpdateReviewAsync(Review review);
    }
}