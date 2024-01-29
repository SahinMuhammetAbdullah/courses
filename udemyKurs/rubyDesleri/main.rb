class NumberGenerator
  DEFAULT_LOWER = 1
  DEFAULT_UPPER = 100
  DEFAULT_ATTEMPTS = 3

  attr_reader :attempts_left, :last, :lower, :upper

  def initialize(attempts = DEFAULT_ATTEMPTS)
    @attempts_left = attempts
    @lower = DEFAULT_LOWER
    @upper = DEFAULT_UPPER
    @last = nil
  end

  def call
    return nil if @attempts_left.zero?

    @last = rand(@lower..@upper)
    @attempts_left -= 1
    @last
  end

  def reset
    @attempts_left = DEFAULT_ATTEMPTS
  end

  def setup(lower: @lower, upper: @upper)
    @lower = lower
    @upper = upper
  end
end

generator = NumberGenerator.new
puts generator.call
puts generator.call
puts generator.call
puts generator.call
puts generator.call
puts generator.call
puts generator.call
puts generator.call
puts generator.left

