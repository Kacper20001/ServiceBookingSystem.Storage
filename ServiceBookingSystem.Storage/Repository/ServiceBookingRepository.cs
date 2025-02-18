using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBookingSystem.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServiceBookingSystem.Storage.Repository
{
    public class ServiceBookingRepository : IServiceBookingRepository
    {
        private readonly ServiceBookingDbContext _context;

        public ServiceBookingRepository(ServiceBookingDbContext context)
        {
            _context = context;
        }

        // User Management
        public async Task<List<User>> GetUsersAsync() => await _context.Users.ToListAsync();
        public async Task<User> GetUserByIdAsync(string userId) => await _context.Users.FindAsync(userId);
        public async Task AddUserAsync(User user) { _context.Users.Add(user); await _context.SaveChangesAsync(); }
        public async Task DeleteUserAsync(string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null) { _context.Users.Remove(user); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateUserAsync(User user) { _context.Users.Update(user); await _context.SaveChangesAsync(); }

        // Role Management
        public async Task<List<Role>> GetRolesAsync() => await _context.Roles.ToListAsync();
        public async Task<Role> GetRoleByIdAsync(int roleId) => await _context.Roles.FindAsync(roleId);
        public async Task AddRoleAsync(Role role) { _context.Roles.Add(role); await _context.SaveChangesAsync(); }
        public async Task DeleteRoleAsync(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role != null) { _context.Roles.Remove(role); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateRoleAsync(Role role) { _context.Roles.Update(role); await _context.SaveChangesAsync(); }

        // Service Management
        public async Task<List<Service>> GetServicesAsync() => await _context.Services.ToListAsync();
        public async Task<Service> GetServiceByIdAsync(int serviceId) => await _context.Services.FindAsync(serviceId);
        public async Task AddServiceAsync(Service service) { _context.Services.Add(service); await _context.SaveChangesAsync(); }
        public async Task DeleteServiceAsync(int serviceId)
        {
            var service = await _context.Services.FindAsync(serviceId);
            if (service != null) { _context.Services.Remove(service); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateServiceAsync(Service service) { _context.Services.Update(service); await _context.SaveChangesAsync(); }

        //Service Category Management 
        public async Task<List<ServiceCategory>> GetServiceCategoriesAsync() => await _context.ServiceCategories.ToListAsync();
        public async Task<ServiceCategory> GetServiceCategoryByIdAsync(int categoryId) => await _context.ServiceCategories.FindAsync(categoryId);
        public async Task AddServiceCategoryAsync(ServiceCategory category) { _context.ServiceCategories.Add(category); await _context.SaveChangesAsync(); }
        public async Task DeleteServiceCategoryAsync(int categoryId)
        {
            var category = await _context.ServiceCategories.FindAsync(categoryId);
            if (category != null) { _context.ServiceCategories.Remove(category); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateServiceCategoryAsync(ServiceCategory category) { _context.ServiceCategories.Update(category); await _context.SaveChangesAsync(); }


        // Reservation Management
        public async Task<List<Reservation>> GetReservationsAsync() => await _context.Reservations.ToListAsync();
        public async Task<List<Reservation>> GetReservationsByUserIdAsync(string userId) =>
            await _context.Reservations.Where(r => r.UserId == userId).ToListAsync();
        public async Task<Reservation> GetReservationByIdAsync(int reservationId) => await _context.Reservations.FindAsync(reservationId);
        public async Task AddReservationAsync(Reservation reservation) { _context.Reservations.Add(reservation); await _context.SaveChangesAsync(); }
        public async Task DeleteReservationAsync(int reservationId)
        {
            var reservation = await _context.Reservations.FindAsync(reservationId);
            if (reservation != null) { _context.Reservations.Remove(reservation); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateReservationAsync(Reservation reservation) { _context.Reservations.Update(reservation); await _context.SaveChangesAsync(); }


        //Payment Management 
        public async Task<List<Payment>> GetPaymentsAsync() => await _context.Payments.ToListAsync();
        public async Task<Payment> GetPaymentByIdAsync(int paymentId) => await _context.Payments.FindAsync(paymentId);
        public async Task AddPaymentAsync(Payment payment) { _context.Payments.Add(payment); await _context.SaveChangesAsync(); }
        public async Task DeletePaymentAsync(int paymentId)
        {
            var payment = await _context.Payments.FindAsync(paymentId);
            if (payment != null) { _context.Payments.Remove(payment); await _context.SaveChangesAsync(); }
        }
        public async Task UpdatePaymentAsync(Payment payment) { _context.Payments.Update(payment); await _context.SaveChangesAsync(); }

        //Review Management
        public async Task<List<Review>> GetReviewsAsync() => await _context.Reviews.ToListAsync();
        public async Task<List<Review>> GetReviewsByServiceIdAsync(int serviceId) =>
            await _context.Reviews.Where(r => r.ServiceId == serviceId).ToListAsync();
        public async Task<Review> GetReviewByIdAsync(int reviewId) => await _context.Reviews.FindAsync(reviewId);
        public async Task AddReviewAsync(Review review) { _context.Reviews.Add(review); await _context.SaveChangesAsync(); }
        public async Task DeleteReviewAsync(int reviewId)
        {
            var review = await _context.Reviews.FindAsync(reviewId);
            if (review != null) { _context.Reviews.Remove(review); await _context.SaveChangesAsync(); }
        }
        public async Task UpdateReviewAsync(Review review) { _context.Reviews.Update(review); await _context.SaveChangesAsync(); }
    }
}
